import React, { Component } from 'react';
import { useState, useEffect } from 'react';
import axios from 'axios';
import '../style.css';
import GuestsDisplay from './GuestsDisplay';
import GuestsAdd from './GuestsAdd';

const GuestsFetch = () => {

    const [guests, setGuests] = useState([]);

    const [show, setShow] = useState(false);

    useEffect(() => {
        async function fetchData() {
            try {
                const data = (await axios.get("https://localhost:7226/api/Guests")).data
                setGuests(data)
                console.log(data)
            } catch (error) {
                console.log(error)
            }
        }
        fetchData();
    }, [])

    return (
        <div> {
            guests.map((item) => {
                return  <React.Fragment key={item.id}>
                            <GuestsDisplay guests={item} />
                        </React.Fragment>

            })
        }
            <div className="d-grid gap-2 col-6 mx-auto">
                <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" />
                <button type="button" className="btn btn-default btn-lg" onClick={() => setShow(true)}>
                    <span className="fa fa-plus" aria-hidden="true"></span>
                </button>

                <GuestsAdd open={show} onClose={() => setShow(false)} />
                  
            </div>
        </div>
    );
}

export default GuestsFetch
