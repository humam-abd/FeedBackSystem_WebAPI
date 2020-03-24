import React from 'react';
import SignIn from "./SignIn";
import './App.css';
import { BrowserRouter as BR, Route } from "react-router-dom";
import Home from './Home';
import AddFeed from './AddFeed';
import AddQuest from './AddQuest';
import Report from './Report';
import AdmLogin from './AdmLogin';
import UsrLogin from './UsrLogin';

class App extends React.Component {
  render() {
    return (
      <div>
        <BR>
          <Route exact path="/" component={SignIn} />
          <Route exact path="/Home" component={Home} />
          <Route exact path="/AddFeed" component={AddFeed} />
          <Route exact path="/AddQuest" component={AddQuest} />
          <Route exact path="/Report" component={Report} />
          <Route exact path="/AdmLogin" component={AdmLogin} />
          <Route exact path="/UsrLogin" component={UsrLogin} />
        </BR>
      </div>
    );
  }
}

export default App;
