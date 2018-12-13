import React, { Component } from 'react';
import './App.css';
import Layout from './components/Layout';
import ProductTable from './components/products/ProductTable';
import CategoryTable from './components/CategoryTable';
import { BrowserRouter, Route } from 'react-router-dom';

class App extends Component {
  render() {
    return (
      <BrowserRouter>
        <div className="App">
          <Layout>
            {/* <Route exact path='/' component={Home} /> */}
            {/* <Route path='/counter' component={Counter} /> */}
            <Route exact path="/products" component={ProductTable} />
            <Route exact path="/categories" component={CategoryTable} />
          </Layout>
        </div>
      </BrowserRouter>
    );
  }
}

export default App;
