import React, { Component } from 'react';
import './App.css';
import ProductTable from './components/ProductTable';
import NavbarTop from './components/NavbarTop';
import Login from './components/Login';

class App extends Component {
  render() {
    return (
      <div className="App">
        <div className="Header">
          <NavbarTop />
        </div>
        <div className="Content">
          <Login />
        </div>
        <div className="Footer">
          <div />
        </div>
        {/* <ProductTable /> */}
      </div>
    );
  }
}

export default App;
