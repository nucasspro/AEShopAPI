import React, { Component } from 'react';
import TextBox from '../TextBox';
import axios from 'axios';

export default class ProductDetail extends Component {
  state = {
    product: {
      id: '0',
      sku: '',
      name: '',
      description: '',
      detail: '',
      productStatusType: '',
      productImage: '',
      image1: '',
      image2: null,
      image3: null,
      image4: null,
      quantity: '',
      promotionPrice: '',
      regularPrice: '',
      weight: null,
      width: null,
      height: null,
      length: null,
      includeVAT: null,
      viewCounts: null,
      warranty: null,
      insertedAt: '',
      updatedAt: ''
    },
    isLoading: true,
    error: null
  };

  componentDidMount() {
    this.getProductDetail();
  }

  async getProductDetail() {
    try {
      const response = await axios.get(
        `http://localhost:8878/api/products/${this.props.match.params.id}`
      );
      console.log(response.data);

      this.setState({
        product: response.data,
        isLoading: false
      });
    } catch (error) {
      this.setState({
        isLoading: false,
        error: error
      });
    }
  }

  async putUpdateProduct() {
    try {
      const jsonData = {
        id: this.state.product.id,
        name: 'test update',
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

      await axios.put(
        `http://localhost:8878/api/products/${this.state.product.id}`,
        jsonData,
        axiosConfig
      );
    } catch (error) {}
  }

  handleSubmit = event => {
    event.preventDefault();
    this.putUpdateProduct();
  };

  render() {
    const { product, isLoading } = this.state;
    return (
      <React.Fragment>
        {!isLoading ? (
          <div>
            <form onSubmit={this.handleSubmit}>
              <TextBox
                htmlFor="sku-input"
                content="SKU"
                type="text"
                placeHolder="Sku"
                value={product.sku}
                id="sku-input"
              />
              <TextBox
                htmlFor="name-input"
                content="Name"
                type="text"
                placeHolder="Name"
                value={product.name}
                id="name-input"
              />
              <TextBox
                htmlFor="description-input"
                content="description"
                type="text"
                placeHolder="Description"
                value={product.description}
                id="description-input"
              />
              <TextBox
                htmlFor="productImage-input"
                content="Thumbnail"
                type="text"
                placeHolder="Thumbnail link"
                value={product.productImage}
                id="productImage-input"
              />

              <TextBox
                htmlFor="image1-input"
                content="Image 1"
                type="text"
                placeHolder="Image link 1"
                value={product.image1}
                id="image1-input"
              />

              <TextBox
                htmlFor="image2-input"
                content="Image 2"
                type="text"
                placeHolder="Image link 2"
                value={product.image2}
                id="image2-input"
              />

              <TextBox
                htmlFor="image3-input"
                content="Image 3"
                type="text"
                placeHolder="Image link 3"
                value={product.image3}
                id="image3-input"
              />

              <TextBox
                htmlFor="image4-input"
                content="Image 4"
                type="text"
                placeHolder="Image link 4"
                value={product.image4}
                id="image4-input"
              />
              <TextBox
                htmlFor="quantity-input"
                content="Quantity"
                type="number"
                placeHolder="Quantity"
                value={product.quantity}
                id="quantity-input"
              />

              <TextBox
                htmlFor="promotionPrice-input"
                content="Promotion Price"
                type="number"
                placeHolder="Promotion Price"
                value={product.promotionPrice}
                id="promotionPrice-input"
              />

              <TextBox
                htmlFor="regularPrice-input"
                content="Regular Price"
                type="number"
                placeHolder="Regular Price"
                value={product.regularPrice}
                id="regularPrice-input"
              />

              <TextBox
                htmlFor="weight-input"
                content="Weight"
                type="number"
                placeHolder="Weight"
                value={product.weight}
                id="weight-input"
              />

              <TextBox
                htmlFor="width-input"
                content="Width"
                type="number"
                placeHolder="Width"
                value={product.width}
                id="width-input"
              />

              <TextBox
                htmlFor="height-input"
                content="Height"
                type="number"
                placeHolder="Height"
                value={product.height}
                id="height-input"
              />

              <TextBox
                htmlFor="length-input"
                content="Length"
                type="number"
                placeHolder="Length"
                value={product.length}
                id="length-input"
              />
              <TextBox
                htmlFor="viewCounts-input"
                content="View Counts"
                type="number"
                placeHolder="View Counts"
                value={product.viewCounts}
                id="viewCounts-input"
              />

              <TextBox
                htmlFor="warranty-input"
                content="Warranty"
                type="number"
                placeHolder="Warranty"
                value={product.warranty}
                id="warranty-input"
              />

              <TextBox
                htmlFor="insertedAt-input"
                content="Inserted At"
                type="text"
                placeHolder="Inserted At"
                value={product.insertedAt}
                id="insertedAt-input"
              />

              <TextBox
                htmlFor="updatedAt-input"
                content="Updated At"
                type="text"
                placeHolder="Updated At"
                value={product.updatedAt}
                id="updatedAt-input"
              />

              <button type="submit">Update</button>
            </form>
          </div>
        ) : (
          <p>Not Found</p>
        )}
      </React.Fragment>
    );
  }
}
