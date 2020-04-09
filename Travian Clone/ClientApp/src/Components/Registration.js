import React, { Component } from 'react';


class Registration extends Component {

    state = {
        UserName: '',
        Password: '',
        
    }

    handleSubmit = (e) => {
        e.preventDefault();
        const requestOptions = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({ UserName: this.state.UserName, Password: this.state.Password })
        };
        fetch('https://localhost:44304/registration', requestOptions)
            .then((response) => response.json())
            .then((json) => {
                if (json)
                {
                    this.props.handleRegistration(this.state);
                }
            })
        
        
    }

        render() {
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
                            value="Register"
                        />
                    </form>
                </div>
            );
        }
}
export default Registration;