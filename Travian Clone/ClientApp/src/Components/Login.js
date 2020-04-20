import React, { useState } from 'react';
import Registration from './Registration'


const Login = props => {

    const [state, setState] = useState({
        UserName: '',
        Password: '',
        isRegistration: false
    })

    const refreshLoginStatus = props.RefreshLoginStatus;

    const handleSubmit = (e) => {
        e.preventDefault();
        const requestOptions = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(state)
        };
        fetch('https://localhost:44304/login', requestOptions)
            .then(() => { refreshLoginStatus(); })
        
    }

    const handleRegistrationStatusChange = (state) => {
        let stateClone = {...state,
            UserName: state.UserName,
            Password: state.Password,
            isRegistration: false
        }
        setState(stateClone);
    }

    const handleRegistrationButton = () => { setState({...state, isRegistration : true }) }


        if (!state.isRegistration) {
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
                            value="Login"
                        />
                    </form>

                    <button onClick={handleRegistrationButton}>Registration</button>
                </div>
            );
        } else {
            return (<Registration handleRegistration={handleRegistrationStatusChange} />)
        }
    }


export default Login;