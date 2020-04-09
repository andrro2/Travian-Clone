import React, { Component } from 'react';
import Registration from './Registration'


class Login extends Component {

    state = {
        UserName: '',
        Password: '',
        isRegistration: false
    }

    refreshLoginStatus = this.props.RefreshLoginStatus;

    handleSubmit = (e) => {
        e.preventDefault();
        const requestOptions = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(this.state)
        };
        fetch('https://localhost:44304/login', requestOptions)
            .then(() => { this.refreshLoginStatus(); })
        
    }

    handleRegistrationStatusChange = (state) => {
        let stateClone = {
            UserName: state.UserName,
            Password: state.Password,
            isRegistration: false
        }
        this.setState(stateClone);
    }

    handleRegistrationButton = () => { this.setState({ isRegistration : true }) }

    render() {
        if (!this.state.isRegistration) {
            return (

                <div>
                    <form onSubmit={this.handleSubmit}>
                        <input
                            type="text"
                            name="UserName"
                            placeholder="Username"
                            value={this.state.UserName}
                            onChange={(e) => this.setState({ UserName: e.target.value })}
                        />
                        <input
                            type="password"
                            name="Password"
                            placeholder="Password"
                            value={this.state.Password}
                            onChange={(e) => this.setState({ Password: e.target.value })}
                        />
                        <input
                            type="submit"
                            value="Login"
                        />
                    </form>

                    <button onClick={this.handleRegistrationButton}>Registration</button>
                </div>
            );
        } else {
            return (<Registration handleRegistration={this.handleRegistrationStatusChange} />)
        }
    }
}

export default Login;