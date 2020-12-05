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
      </header>
    </div>
  );
}

export default App;
