import './Listing.scss';
import ExerciseItem from './ExerciseItem';
import React from 'react';
import ReactDOM from 'react-dom';

class ExerciseListing extends React.Component {
    constructor(props) {
      super(props);
      this.state = {jsonData: []}
    }

    getExercises() {

      fetch("https://localhost:5001/api/exercise/test/two")
      .then(response => response.json())
      .then(list => {
        this.setState({jsonData: list});
      });
    }


    render() {
      this.getExercises();
      return (
        <div className="listing">
          <h1>Exercises</h1>
          {this.state.jsonData.map((exercise) =>
            <ExerciseItem name={exercise.name} />
          )}
        </div>
      );
    }
}

export default ExerciseListing;
