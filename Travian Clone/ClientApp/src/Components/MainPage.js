import React, { Component } from 'react';
import MainPageheader from './MainPageheader';

class MainPage extends Component {

    constructor(props) {
        super(props)
        this.state = props.userData
        this.LogOut = props.LogOut;
    }

    LogOut = null

    state = {}

    render() {
        
        return (
            <div>
                <MainPageheader userData={this.state} LogOut={this.LogOut} />
            </div>
        );
        
    }
}

export default MainPage;
