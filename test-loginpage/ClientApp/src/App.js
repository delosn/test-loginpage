import React from 'react';
import { Routes, Route } from "react-router-dom";
import './App.css';
import Navbar from './components/navbar/Navbar';
import Home from './components/pages/Home';
import LoginPage from './components/pages/LoginPage';
import TestDisplay from './components/pages/TestDisplay';
import 'bootstrap/dist/css/bootstrap.min.css';

export default function App() {
    return (
        <div>
            <Navbar />
            <Routes>
                <Route path='/' exact element={<Home />} />
                <Route path='/login' element={<LoginPage />} />
                <Route path='/data-display' element={<TestDisplay />} />
            </Routes>
        </div>


        );
}


//SignUp
//SignIn
//Main Page
    //Add Post
    //Delete Post
    //Add Image


// Add CORS Support to connect to database.