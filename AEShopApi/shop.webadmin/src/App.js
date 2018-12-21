import React, { Component } from 'react';
import './App.css';
import Layout from './components/Layout';
import ProductTable from './components/products/ProductTable';
import CategoryTable from './components/CategoryTable';
import ProductDetail from './components/products/ProductDetail';
import DashBoard from './components/DashBoard';
import { BrowserRouter, Route } from 'react-router-dom';

class App extends Component {
  render() {
    return (
      <BrowserRouter>
        <div className="App">
          <Layout>
            <Route exact path="/" component={DashBoard} />
            <Route exact path="/products" component={ProductTable} />
            <Route exact path="/productdetail/:id" component={ProductDetail} />
            <Route exact path="/categories" component={CategoryTable} />
          </Layout>
        </div>
      </BrowserRouter>
    );
  }
}

export default App;
