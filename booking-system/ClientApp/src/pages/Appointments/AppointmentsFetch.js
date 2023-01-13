import React, { Component } from 'react';
import { useState, useEffect } from 'react';
import axios from 'axios';
import '../style.css';
import AppointmentsDisplay from './AppointmentsDisplay';
import AppointmentsAdd from './AppointmentsAdd';


const AppointmentsFetch = () => {

    const [Appointments, setAppointments] = useState([]);

    const [date, setDate] = useState();

    const [skipCount, setSkipCount] = useState(true);

    const [show, setShow] = useState(false);

    function setDateValue() {
        var datevalue = date + "T00:00:00.000Z";
        return datevalue
    }

    useEffect(() => {
        if (skipCount) setSkipCount(false);
        if (!skipCount) fetchData();
    }, [date])

    var fetchDateUrl = ({ datevalue }) => `https://localhost:7226/api/Appointments/${datevalue}`;

    async function fetchData() {
        try {
            var datevalue = setDateValue();            
            const data = (await axios.get(fetchDateUrl({ datevalue: datevalue }))).data;
            setAppointments(data)
        } catch (error) {
        }
    }

    return (
        <div>
            <input type="date" format='YYYY-MM-DD' onChange={e => setDate(e.target.value)} />

            {
            Appointments.map((item) => {
                return <React.Fragment key={item.id}>
                    <AppointmentsDisplay Appointments={item} />
                </React.Fragment>

            })
            }
            <div className="d-grid gap-2 col-6 mx-auto">
                <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" />
                <button type="button" className="btn btn-default btn-lg" onClick={() => setShow(true)}>
                    <span className="fa fa-plus" aria-hidden="true"></span>
                </button>

                <AppointmentsAdd open={show} onClose={() => setShow(false)} />

            </div>
        </div>
    );
}

export default AppointmentsFetch

