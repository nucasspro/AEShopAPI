import React, { Component } from 'react';
import axios from 'axios';
class Product extends Component {
    state = {
        products  =[]
    };

    componentWillMount() {
        axios.get('')
            .then(response => { this.setState({ posts: response.data }) })
            .catch(function (error) { console.log(error); });
        console.log(this.state.posts)
    }

    render() {
        return (
            <div>

            </div>
        )
    };
};
export default Product;