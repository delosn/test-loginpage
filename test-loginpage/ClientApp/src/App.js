import React from 'react';
import { Routes, Route } from "react-router-dom";
import './App.css';
import Navbar from './components/navbar/Navbar';
import Home from './components/pages/Home';
import 'bootstrap/dist/css/bootstrap.min.css';

export default function App() {
    return (
        <div>
            <Navbar />
            <Routes>
                <Route path='/' exact element={<Home />}/>
            </Routes>
        </div>


        );
}