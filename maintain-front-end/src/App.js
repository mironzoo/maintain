import './App.scss';
import Button from 'react-bulma-components/lib/components/button';

function App() {
  return (
    <div className="App-header">
      <p>Version 1.0.0</p>
      <header className="App-header">
        <p>Login to Maintain</p>
        <Button color='primary'>Login</Button>
        <p>Register an Account</p>
        <Button color='primary'>Register</Button>
        <Button color='primary' onClick={() => {
          fetch("https://localhost:5001/api/exercise/test/two")
          .then(response => response.json())
          .then(list => {
            list.forEach(exercise => {
              document.getElementById("sampletext").innerHTML = exercise.name;
              console.log(exercise);
            })
          })

        }}>get test one</Button>
        <p id="sampletext">sample text</p>
      </header>
    </div>
  );
}

export default App;
