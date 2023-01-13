import React, { Component } from 'react';
import '../cardStyle.css';


function AppointmentsDisplay({ Appointments }) {
    return (
        <ul className="list-group list-group-flush">
            <a href="#" className="list-group-item-try list-group-item-action" aria-current="true">
                <div className="d-flex w-100 justify-content-between">
                    <h6 className="mb-1">{Appointments.guestName}</h6>
                </div>
                <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" />
                <p className="pptt">
                    <span className="fa fa-user" aria-hidden="true"></span> {Appointments.staffsName}
                </p>
                <p className="pptt">
                    <span className="fa fa-check" aria-hidden="true"></span> {Appointments.serviceName}
                </p>
                <p className="pptt">
                    <span className="fa fa-calendar" aria-hidden="true"></span> {Appointments.bookingTime}
                </p>
            </a>

        </ul>
    )
}

export default AppointmentsDisplay