import React from 'react';
import { useState } from 'react';
import { Button } from 'react-bootstrap';
import './TestDisplay.css';

export default function LoginPage() {


    const [showData, setShowData] = useState('');

    const fetchData = () =>
        fetch("insert info here")
            .then(showData => setShowData(showData))

    return (
        <div className='test-container'>
            <h1>Test Display</h1>
            <div className='test-btns'>
                <Button
                    className="btn-primary"
                    id='dark'
                    variant='dark'
                    onClick={fetchData()}
                 >Get Data</Button>
            </div>
        </div>
    );
}

