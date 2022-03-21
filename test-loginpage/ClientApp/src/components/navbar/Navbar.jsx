import React from 'react';
import { Link } from 'react-router-dom';
import './Navbar.css';

export default function Navbar() {
    return (
        <div>
            <nav className="navbar">
                <div className="navbar-container">
                    <Link to='/' className="nav-links">
                        Home
                    </Link>
                </div>
            </nav>
        </div>
        )
}

