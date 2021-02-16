import './App.scss';
import React from 'react';

//Pages and Forms
import LoginForm from './Components/Forms/LoginForm';
import HomePage from './Components/Contents/Homepage.js';
import NavHeader from './Components/Contents/NavHeader.js';
import Stage from './Components/Contents/Stage';
import ReactDOM from 'react-dom';
import {createHashHistory} from 'history';


//Routing
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom";

export const history = createHashHistory()

function App() {

  return (
    <div className="App">
      <Router history={history}>
        <Stage />
      </Router>
    </div>
  );
}

export default App;
