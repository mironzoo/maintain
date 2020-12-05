import './../../App.scss';
import React from 'react';
import ReactDOM from 'react-dom';

class HomeContents extends React.Component {
    constructor(props) {
          super(props);
          console.log('Rendered ');
    }

    render() {
      return (
        <div id='homecontents'>
          hi
        </div>
      );
    }
}

export default HomeContents;
