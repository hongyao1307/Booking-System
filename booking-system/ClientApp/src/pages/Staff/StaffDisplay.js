import React, { Component } from 'react';
import '../cardStyle.css';


function StaffDisplay({ Staff }) {
    return (
        <ul className="list-group list-group-flush">
            <a href="#" className="list-group-item-try list-group-item-action" aria-current="true">
                <div className="d-flex w-100 justify-content-between">
                    <h6 className="mb-1">{Staff.firstName} {Staff.lastName}</h6>
                </div>
                <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" />
                <p className="pptt">
                    <span className="fa fa-user" aria-hidden="true"></span> {Staff.jobTitle}
                </p>
            </a>

        </ul>
    )
}

export default StaffDisplay
