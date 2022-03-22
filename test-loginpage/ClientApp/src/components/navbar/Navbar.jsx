import React from 'react';
import { Link } from 'react-router-dom';
import './Navbar.css';
import profile_pic from '../../images/profile-icon-white.png'

export default function Navbar() {
    return (
        <div>
            <nav className="navbar">
                <div className="navbar-container">
                    <Link to='/' className="nav-links">
                        Home
                    </Link>
                    <Link to='/profile' className="nav-Links">
                        <img className='profile-pic' src={profile_pic} alt='Profile' />
                    </Link>
                </div>
            </nav>
        </div>
        )
}

