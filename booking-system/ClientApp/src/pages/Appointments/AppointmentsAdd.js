import React, { Component, useState, useEffect } from 'react';
import { Modal, Button } from 'react-bootstrap';
import axios from 'axios';
import '../ModalStyle.css';


const AppointmentsAdd = ({ open, onClose }) => {
    if (!open) return null

    return (
        <div class="modalContainer" tabIndex="-1" onClick={() => console.log("clicked")}>

            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">New Appointment</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close" onClick={onClose}></button>
                </div>
                <div class="modal-body">
                    {/**<AppointmentsAddForm data={onClose} />*/}
                </div>
            </div>
        </div>

    )
}

export default AppointmentsAdd

