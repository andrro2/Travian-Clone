import React, { useState, useEffect } from 'react';
import MainPageheader from './MainPageheader';

const MainPage = props => {

    const LogOut = null

    const [state, setState] = useState({})

    useEffect(() => { setState(props.userData); LogOut = props.LogOut })

        
    return (
        <div>
            <MainPageheader userData={state} LogOut={LogOut} />
        </div>
    );

}

export default MainPage;
