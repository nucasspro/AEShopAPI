import React, { Component } from 'react';
import { Table } from 'reactstrap';
import axios from 'axios';

export default class ProductTable extends Component {
  // Initial state of component
  state = {
    products: [],
    isLoading: true,
    error: null
  };

  // Call API to get product with asynchronous
  async getProducts() {
    var response = await axios.get('https://localhost:5001/api/products');
    try {
      this.setState({
        products: response.data,
        isLoading: false
      });
    } catch (error) {
      this.setState({
        error: error,
        isLoading: false
      });
    }
  }

  componentDidMount() {
    this.getProducts();
  }

  render() {
    const { isLoading, products } = this.state;

    // If isLoading == false => Show "Loading..."
    // Else => Show table
    return (
      <React.Fragment>
        {!isLoading ? (
          <Table>
            <thead>
              <tr>
                <th>#</th>
                <th>Id</th>
                <th>Name</th>
              </tr>
            </thead>
            <tbody>
              {products.map((item, index) => (
                <tr key={index}>
                  <th>{index}</th>
                  <td>{item.id}</td>
                  <td>{item.name}</td>
                </tr>
              ))}
            </tbody>
          </Table>
        ) : (
          <p>Loading...</p>
        )}
      </React.Fragment>
    );
  }
}
