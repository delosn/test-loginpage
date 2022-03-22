import React from 'react';
import { Button } from 'react-bootstrap';
import './HeroSection.css'



export default function HeroSection() {

    return (
        <div className='hero-container'>
            {/* <video src="/videos/video-2.mp4" autoPlay loop muted /> */}
            <h1>WELCOME!</h1>
            <p>Choose From the Options</p>
            <div className='hero-btns'>
                <Button
                    className="btn-primary"
                    id='light'
                    variant='light'
                >
                    Login
                </Button>
                <Button
                    className="btn-primary"
                    id='dark'
                    variant="dark"
                >
                    Create Profile
                </Button>
            </div>
        </div>
        );
}