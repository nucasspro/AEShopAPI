import React, { Component } from 'react';
import Posts from './components/Posts';
//import Postfrom from './components/postForm';
import Product from './components/Product';
import store from './store';
import { Provider } from 'react-redux';

class App extends Component {
    render() {
        return (
            <Provider store={store}>
                <div className="App">
                    <Product></Product>
                    <hr />
                </div>
            </Provider>
        );
    }
}

export default App;
