import React, { useState } from 'react';


const Registration = props => {

    const [state, setState] = useState({
        UserName: '',
        Password: '',
        
    })

    const handleSubmit = (e) => {
        e.preventDefault();
        const requestOptions = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({ UserName: state.UserName, Password: state.Password })
        };
        fetch('https://localhost:44304/registration', requestOptions)
            .then((response) => response.json())
            .then((json) => {
                if (json)
                {
                    props.handleRegistration(state);
                }
            })
        
        
    }

    return (
        <div>
            <form onSubmit={handleSubmit}>
                <input
                    type="text"
                    name="UserName"
                    placeholder="Username"
                    value={state.UserName}
                    onChange={(e) => setState({...state, UserName: e.target.value })}
                />
                <input
                    type="password"
                    name="Password"
                    placeholder="Password"
                    value={state.Password}
                    onChange={(e) => setState({...state, Password: e.target.value })}
                />
                <input
                    type="submit"
                    value="Register"
                />
            </form>
        </div>
    );
}

export default Registration;