import './App.scss';
import Button from 'react-bulma-components/lib/components/button';
import HomeContents from './Components/Contents/HomeContents';
import ExerciseListing from './Components/Listing/ExerciseListing';

function App() {
  
  return (
    <div className="App">

      <header className="App-header">
      <p>Version 1.0.0</p>
      </header>

      <input className="input is-large" type="text" placeholder="User Id" />
      <Button color='primary'>Login</Button>
    </div>
  );
}

export default App;
