import React, { Component, useState, useEffect } from 'react';
import axios from 'axios';

export default class GuestsAddForm extends Component {
    constructor(props) {
        super(props);
        this.state = {
            firstName: "",
            lastName: "",
            phoneNumber: "",
            email: "",
        }
    }

    onSubmit = async (events) => {
        /**Prevent default jumpping */
        events.preventDefault();
        console.log(this.state);
        await axios.post("https://localhost:7226/api/Guests", this.state);
        this.HandleClose(events);
    }

    HandleChange = (events) => {
        this.setState({
            [events.target.name]: events.target.value
        })
    };

    HandleClose () {
        this.props.data({});
    }

    render() {
        return (
            <div>
                <form onSubmit={this.onSubmit}>
                    <div className='form-group'>
                        <label className='control-label'>First Name</label>
                        <input
                            className='form-control'
                            type='text'
                            name='firstName'
                            value={this.state.firstName}
                            onChange={this.HandleChange}
                        />
                        <label className='control-label'>Last Name</label>
                        <input
                            className='form-control'
                            type='text'
                            name='lastName'
                            value={this.state.lastName}
                            onChange={this.HandleChange}
                        />
                        <label className='control-label'>Phone Number</label>
                        <input
                            className='form-control'
                            type='text'
                            name='phoneNumber'
                            value={this.state.phoneNumber}
                            onChange={this.HandleChange}
                        />
                        <label className='control-label'>E-mail</label>
                        <input
                            className='form-control'
                            type='text'
                            name='email'
                            value={this.state.email}
                            onChange={this.HandleChange}
                        />
                    </div>
                    <div className='form-group'>
                        <p />
                        <button className='btn btn-light'>Add</button>
                    </div>
                </form>

            </div>
        )
    }

}