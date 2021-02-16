import './../../App.scss';
import React from 'react';

//Pages and Forms
import LoginForm from '../Forms/LoginForm';
import HomePage from './Homepage.js';
import NavHeader from './NavHeader.js';
import ReactDOM from 'react-dom';

//Routing
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom";
import {history} from '../../App';


class Stage extends React.Component {
    constructor(props) {
          super(props);
          this.state = {
            pid: -1
          }
          this.loginPid = this.loginPid.bind(this);
    }

    loginPid(id) {
      this.setState({
        pid: id
      });
    }

    render() {
      var element;
      var welcome;
      var logOut = false;

      if (this.state.pid != -1) {
        welcome = <span style={{marginLeft: '32px', marginTop: '16px'}}> Welcome {this.state.pid} </span>
        logOut = true;
      }

      return (<div>
              <NavHeader Welcome={welcome} logOut={logOut} loginPid={this.loginPid}/>
                <Router>
                  <Switch>
                    <Route path="/">
                      <LoginForm loginPid={this.loginPid}  history={history}/>
                    </Route>

                    <Route path="/home">
                      <HomePage pid={this.state.pid}/>
                    </Route>
                  </Switch>
                </Router>
              </div>);
    }
}

export default Stage;
