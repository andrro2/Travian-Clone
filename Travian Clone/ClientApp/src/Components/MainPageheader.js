import React, { useState, useEffect } from 'react';


const MainPageheader = props => {

    const [state, setState] = useState({
        UserName: '',
        isAdmin: false
    })

    useEffect(() => { setState({ UserName: props.UserName, isAdmin: props.isAdmin }) }, [])
    
    return (
        <header>
            <p>{state.isAdmin ? state.UserName + ' (Admin)' : state.UserName}</p>
            <button>Settings</button>
            {state.isAdmin &&
                <button>Admin Settings</button>
            }
            <button onClick={props.LogOut}>Logout</button>

        </header>
        )
    
}
export default MainPageheader;