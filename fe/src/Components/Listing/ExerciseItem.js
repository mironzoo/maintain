import './../../App.scss';
import React from 'react';
import ReactDOM from 'react-dom';

class ExerciseItem extends React.Component {
  constructor(props) {
    super(props);
    console.log('RENDERDE!!' + props.name);
  }

  render() {
    return (
      <p>{this.props.name}</p>
    );
  }
}

export default ExerciseItem;
