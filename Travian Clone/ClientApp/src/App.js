import React, {useState, useEffect} from 'react';
import './App.css';
import MainPage from './Components/MainPage';
import Login from './Components/Login';


const App = props => {
    const [state, setState] = useState({
        UserName: null,
        isAdmin: false,
        isLoggedIn: false,
        isLoading: true
    });

    const RefreshLoginStatus = () => {
        setState({...state, isLoading: true })
        fetch('https://localhost:44304/login')
            .then(response => response.json())
            .then((json) => {
                console.log(json);
                setState({...state, 
                    UserName : json.username,
                    isAdmin : json.isAdmin,
                    isLoggedIn: json.isLoggedIn,
                    isLoading: false
                })
            })
        
    }

    const LogOut = () => {
        fetch('https://localhost:44304/login/logout')
            .then(response => response.json())
            .then((json) => {
                console.log(json);
                setState({...state,
                    UserName: null,
                    isAdmin: false,
                    isLoggedIn: false
                })
            })
    }

    useEffect(() => { RefreshLoginStatus(); }, [])

    if (!state.isLoading) {
        if (!state.isLoggedIn) {
            return (
                <Login RefreshLoginStatus={RefreshLoginStatus} />
            );
        }
        return (
            <MainPage userData={state} LogOut={LogOut} />
        );
    }
    return(<p>Loading</p>)

    
}

export default App;
