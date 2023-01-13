import React, { Component } from 'react';
import '../cardStyle.css';


function GuestsDisplay({ guests }) {
    return (
        <ul className="list-group list-group-flush">
            <a href="#" className="list-group-item-try list-group-item-action" aria-current="true">
                <div className="d-flex w-100 justify-content-between">
                    <h6 className="mb-1">{guests.firstName} {guests.lastName}</h6>
                </div>
                <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" />
                <p className="pptt">
                    <span className="fa fa-envelope" aria-hidden="true"></span> {guests.phoneNumber}
                </p>
                <p className="pptt">
                    <span className="fa fa-phone" aria-hidden="true"></span> {guests.email}
                </p>
            </a>

        </ul>
        )
}

export default GuestsDisplay