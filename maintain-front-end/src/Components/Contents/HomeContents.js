import './../../App.scss';
import React from 'react';
import LoginForm from '../Forms/LoginForm'
import ReactDOM from 'react-dom';

class HomeContents extends React.Component {
    constructor(props) {
          super(props);
          console.log('Rendered ');
    }

    changeContents = (data) => {
      this.setState({
        currentPage: data
      });
    }

    render() {
      return (
        <div id='homecontents'>
          <LoginForm onLogin={this.changeContents} />
        </div>
      );
    }
}

export default HomeContents;
