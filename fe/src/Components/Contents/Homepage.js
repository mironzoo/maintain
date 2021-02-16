import React from 'react';
import Button from 'react-bulma-components/lib/components/button';
import './Menu.scss'

class HomePage extends React.Component {

  render() {
    return (
      <div>
        <p> Workout Application </p>
        <div className='menuOption'>
          <Button color='primary'> Begin Workout </Button>
        </div>
        <div className='menuOption'>
          <Button color='primary'> View Exercise Listing </Button>
        </div>
        <div className='menuOption'>
          <Button color='primary'> View Workout History </Button>
        </div>
      </div>
    );
  }
}

export default HomePage;
