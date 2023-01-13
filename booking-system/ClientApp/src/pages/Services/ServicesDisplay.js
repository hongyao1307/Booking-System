import React, { Component } from 'react';
import '../cardStyle.css';


function ServicesDisplay({ Services }) {
    return (
        <ul className="list-group list-group-flush">
            <a href="#" className="list-group-item-try list-group-item-action" aria-current="true">
                <div className="d-flex w-100 justify-content-between">
                    <h6 className="mb-1">{Services.name}</h6>
                </div>
                <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" />
                <p className="pptt">
                    <span className="fa fa-comment" aria-hidden="true"></span> {Services.category}
                </p>
                <p className="pptt">
                    <span className="fa fa-dollar" aria-hidden="true"></span> {Services.price}
                </p>
            </a>

        </ul>
    )
}

export default ServicesDisplay