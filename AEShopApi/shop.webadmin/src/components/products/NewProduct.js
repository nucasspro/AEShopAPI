import React, { Component } from 'react';
import TextBox from '../TextBox';
import axios from 'axios';

export default class NewProduct extends Component {
  
  componentDidMount() {}

  render() {
    const handleSubmit = event => {
      event.preventDefault();
      let newProduct = {
        name: 'aaaaaaaaaaaaa',
        sku: 'sku3',
        quantity: 10,
        ProductStatusId: 2,
        description: 'Phần des',
        detail: 'Phần detail',
        weight: null,
        width: null,
        height: null,
        length: null,
        promotionPrice: 12,
        regularPrice: 15,
        categoryId: 1,
        image1: 'akksn',
        image2: null,
        image3: null,
        image4: null,
        discountId: null
      };

      let axiosConfig = {
        headers: {
          'Content-Type': 'application/json;charset=UTF-8',
          'Access-Control-Allow-Origin': '*'
        }
      };

      axios
        .post('http://localhost:8878/api/products', newProduct, axiosConfig)
        .then(res => {
          console.log('RESPONSE RECEIVED: ', res);
        })
        .catch(err => {
          console.log('AXIOS ERROR: ', err);
        });
    };

    return (
      <React.Fragment>
        <div className="card">
          <div className="card-body">
            <form onSubmit={handleSubmit}>
              <TextBox
                htmlFor="sku-input"
                content="SKU"
                type="text"
                placeHolder="Sku"
                value=""
                id="sku-input"
              />
              <TextBox
                htmlFor="name-input"
                content="Name"
                type="text"
                placeHolder="Name"
                value=""
                id="name-input"
              />
              <TextBox
                htmlFor="description-input"
                content="description"
                type="text"
                placeHolder="Description"
                value=""
                id="description-input"
              />
              <TextBox
                htmlFor="productImage-input"
                content="Thumbnail"
                type="text"
                placeHolder="Thumbnail link"
                value=""
                id="productImage-input"
              />

              <TextBox
                htmlFor="image1-input"
                content="Image 1"
                type="text"
                placeHolder="Image link 1"
                value=""
                id="image1-input"
              />
              <TextBox
                htmlFor="quantity-input"
                content="Quantity"
                type="number"
                placeHolder="Quantity"
                value=""
                id="quantity-input"
              />

              <TextBox
                htmlFor="promotionPrice-input"
                content="Promotion Price"
                type="number"
                placeHolder="Promotion Price"
                value=""
                id="promotionPrice-input"
              />

              <TextBox
                htmlFor="regularPrice-input"
                content="Regular Price"
                type="number"
                placeHolder="Regular Price"
                value=""
                id="regularPrice-input"
              />
            

              <div className="custom-control custom-checkbox custom-control-inline">
                <input
                  type="checkbox"
                  disabled=""
                  className="custom-control-input"
                  id="customCheck8"
                />
                <label className="custom-control-label" htmlFor="customCheck8">
                  Unchecked Checkbox
                </label>
              </div>
              <button type="submit">save</button>
            </form>
          </div>
        </div>
      </React.Fragment>
    );
  }
}
