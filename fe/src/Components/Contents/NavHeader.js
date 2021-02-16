import React from 'react';
import Navbar from 'react-bulma-components/lib/components/navbar';
import Button from 'react-bulma-components/lib/components/button';
import './../../App.scss';

class NavHeader extends React.Component {
  constructor(props) {
    super(props);
    this.logOut = this.logOut.bind(this);
  }

  logOut() {
    this.props.loginPid(-1);
  }

  render() {
    var logOutBtn;
    if (this.props.logOut) {
      logOutBtn = <Button color='primary' onClick={this.logOut} style={{float: 'right'}}> Log Out </Button>
    }

    return (
      <Navbar style={{  backgroundColor: '#282c34', margin: 'auto', width: '100vw', maxHeight: '5vh' }}>
        {this.props.Welcome}
        {logOutBtn}
      </Navbar>
    );
  }
}

export default NavHeader;
