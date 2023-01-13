import React, { Component } from 'react';
import GuestsFetch from './GuestsFetch';
import Gueststry from './Gueststry';
import GuestsAdd from './GuestsAdd';
import './style.css'

export class GuestsForm extends Component {
    static displayName = GuestsForm.name;
    render() {
        return (
            <div className="row row-cols-1 row-cols-md-5 g-4">
                <div className="col">
                    <div className="card h-100">
                        <div className="card-body">
                            <h5 className="card-title">Guests</h5>
                            <GuestsFetch />
                        </div>
                        {/**<button type="button" className="btn btn-default btn-lg">
                            Add
                        </button>*/}
                    </div>
                </div>

                <div className="col">
                    <div className="card h-100">
                        <div className="card-body">
                            <h5 className="card-title">Staffs</h5>
                            <p className="card-text">This is a short card.</p>
                        </div>
                        <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" />
                        <button type="button" className="btn btn-default btn-lg">
                            <span className="fa fa-star" aria-hidden="true"></span> Star
                        </button> 
                    </div>
                </div>   
            </div>
        )
    }
}