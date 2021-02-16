import React from 'react';
import Button from 'react-bulma-components/lib/components/button';
import {HashRouter as Router,Route,Switch} from 'react-router-dom';
import {history} from '../../App';
import '../../App.scss';
class LoginForm extends React.Component {

  constructor(props) {
    super(props);
    this.state = ({
      userValue: ""
    })
    this.onLogin = this.onLogin.bind(this);

  }

  onType(e) {
    this.setState({
      userValue: e.target.value
    });
  }

  onLogin(e) {

    var myHeaders = new Headers();
    myHeaders.append("Content-Type", "application/json");
    var usrId = JSON.stringify({"pid": this.state.userValue + ""});
    console.log(usrId);

    var requestOptions = {
      method: 'POST',
      headers: myHeaders,
      body: usrId,
      redirect: 'follow'
    };
    fetch("https://localhost:5001/api/Login/loginUser", requestOptions)
      .then(response => response.text())
      .then(result => {
        console.log(result);
        if (result == 'true') {
          this.props.loginPid(this.state.userValue);
          this.props.history.push('/home');
        } else {
          console.alert('wrong pid');
        }
      });
  }

  render() {
    return(
      <div className="App">
        <input className="input is-large"
          type="text"
          placeholder="User Id"
          onKeyUp={event => this.onType(event)}
        />
        <Button color='primary' style={{marginTop: "20px"}}
            onClick={this.onLogin}>Login</Button>
      </div>
    );
  }
}

export default LoginForm;
