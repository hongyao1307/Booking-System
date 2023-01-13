import React, { Component } from 'react';
import GuestsFetch from './Guests/GuestsFetch';
import StaffFetch from './Staff/StaffFetch';
import ServicesFetch from './Services/ServicesFetch';
import AppointmentsFetch from './Appointments/AppointmentsFetch';
import './style.css';

export class HomePage extends Component {
    static displayName = HomePage.name;

    render() {
        return (
            <div>
                <h1>Booking System</h1>
                <div className="row row-cols-1 row-cols-md-5 g-4">
                    <div className="col">
                        <div className="card h-100">
                            <div className="card-body">
                                <h5 className="card-title">Guests</h5>
                                <GuestsFetch />
                            </div>
                        </div>
                    </div>

                    <div className="col">
                        <div className="card h-100">
                            <div className="card-body">
                                <h5 className="card-title">Staff</h5>
                                <StaffFetch />
                            </div>
                        </div>
                    </div>

                    <div className="col">
                        <div className="card h-100">
                            <div className="card-body">
                                <h5 className="card-title">Services</h5>
                                <ServicesFetch />
                            </div>
                        </div>
                    </div>

                    <div className="col">
                        <div className="card-wider h-100">
                            <div className="card-body">
                                <h5 className="card-title">Appointments</h5>
                                <AppointmentsFetch />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
