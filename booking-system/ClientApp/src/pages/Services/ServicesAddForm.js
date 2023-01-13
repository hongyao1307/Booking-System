import React, { Component, useState, useEffect } from 'react';
import axios from 'axios';

export default class ServicesAddForm extends Component {
    constructor(props) {
        super(props);
        this.state = {
            name: "",
            category: "",
            price: ""
        }
    }

    onSubmit = async (events) => {
        /**Prevent default jumpping */
        events.preventDefault();
        console.log(this.state);
        await axios.post("https://localhost:7226/api/Services", this.state);
        this.HandleClose(events);
    }

    HandleChange = (events) => {
        this.setState({
            [events.target.name]: events.target.value
        })
    };

    HandleClose() {
        this.props.data({});
    }

    render() {
        return (
            <div>
                <form onSubmit={this.onSubmit}>
                    <div className='form-group'>
                        <label className='control-label'>Service Name</label>
                        <input
                            className='form-control'
                            type='text'
                            name='name'
                            value={this.state.name}
                            onChange={this.HandleChange}
                        />
                        <label className='control-label'>Category</label>
                        <input
                            className='form-control'
                            type='text'
                            name='category'
                            value={this.state.category}
                            onChange={this.HandleChange}
                        />
                        <label className='control-label'>Price</label>
                        <input
                            className='form-control'
                            type='text'
                            name='price'
                            value={this.state.price}
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
