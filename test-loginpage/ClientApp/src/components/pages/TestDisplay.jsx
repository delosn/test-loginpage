import React from 'react';
import { useState } from 'react';
import { Button } from 'react-bootstrap';
import './TestDisplay.css';

export default function LoginPage() {





    //const getString = async() => {
    //    const response = await fetch("Home/GetData");
    //    const Data = await response.text()
    //    console.log(Data)
    //}

    const [showData, setShowData] = useState('');

    const getString = async () => {
        const response = await fetch("Home/GetData")
        const showData = await response.text()
        setShowData(showData)
    }



    return (
        <div className='test-container'>
            <h1>Test Display</h1>
            <div className='test-btns'>
                <Button
                    className="btn-primary"
                    id='dark'
                    variant='dark'
                    onClick={getString}
                >Get Data</Button>
                <h2>{showData}</h2>
            </div>
        </div>
    );
}







//import React, { useEffect, useState } from 'react';

//const User = () => {
//    const [users, setUsers] = useState([]);

//    useEffect(() => {
//        getUsers();
//    }, []);

//    async function getUsers() {
//        const response = await fetch('https://jsonplaceholder.typicode.com/users');
//        const users = await response.json();
//        setUsers(users);
//    }

//    return (
//        <ul>
//            {users.map(user => (
//                <li>{user.name}</li>
//            ))}
//        </ul>
//    );
//};

//export default User;