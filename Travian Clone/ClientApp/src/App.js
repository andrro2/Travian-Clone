import React, {Component} from 'react';
import './App.css';
import MainPage from './Components/MainPage';
import Login from './Components/Login';


class App extends Component {

    state = {
        UserName: null,
        isAdmin: false,
        isLoggedIn: false
    }

    RefreshLoginStatus = () => {
        fetch('https://localhost:44304/login')
            .then(response => response.json())
            .then((json) => {
                console.log(json);
                this.setState({
                    UserName : json.username,
                    isAdmin : json.isAdmin,
                    isLoggedIn : json.isLoggedIn
                })
            })
        
    }

    LogOut = () => {
        fetch('https://localhost:44304/login/logout')
            .then(response => response.json())
            .then((json) => {
                console.log(json);
                this.setState({
                    UserName: null,
                    isAdmin: false,
                    isLoggedIn: false
                })
            })
    }

    componentDidMount() {
        this.RefreshLoginStatus();
    }

    render() {
        if (!this.state.isLoggedIn) {
            return (
                <Login RefreshLoginStatus={this.RefreshLoginStatus} />
            );
        }
        return (
            <MainPage userData={this.state} LogOut={this.LogOut} />
        );
    }

    
}

export default App;
