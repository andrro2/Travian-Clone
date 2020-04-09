import React, { Component } from 'react';


class MainPageheader extends Component {

    constructor(props) {
        super(props)
        this.state = props.userData
    }

    state = {
        UserName: '',
        isAdmin: false
    }


    render()
    {
        return (
            <header>
                <p>{this.state.isAdmin ? this.state.UserName + ' (Admin)' : this.state.UserName}</p>
                <button>Settings</button>
                {this.state.isAdmin &&
                    <button>Admin Settings</button>
                }
                <button onClick={this.props.LogOut}>Logout</button>

            </header>
            )
    }
}
export default MainPageheader;