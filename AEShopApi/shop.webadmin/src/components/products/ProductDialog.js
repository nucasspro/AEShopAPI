import React from 'react';
import axios from 'axios';
import { BASE_URL } from '../../settings';
import {
  withStyles,
  DialogTitle,
  DialogContent,
  Dialog,
  Button,
  MenuItem,
  TextField
} from '@material-ui/core';

let product = {};

class ProductDialog extends React.Component {
  state = {
    open: false,
    product: {
      name: null,
      sku: null,
      quantity: null,
      ProductStatusTypeId: 1,
      description: null,
      detail: null,
      weight: null,
      width: null,
      height: null,
      length: null,
      promotionPrice: 1,
      regularPrice: null,
      categoryId: 1,
      productImage: null,
      image1: null,
      image2: null,
      image3: null,
      image4: null,
      discountId: null
    },
    categories: []
  };

  componentDidMount() {
    this.getCategories();
  }

  getCategories() {
    // event.preventDefault();
    let axiosConfig = {
      headers: {
        'Content-Type': 'application/json;charset=UTF-8',
        'Access-Control-Allow-Origin': '*'
      }
    };

    axios
      .get(`${BASE_URL}/categories`, axiosConfig)
      .then(res => {
        this.setState({ categories: res.data });
      })
      .catch(err => {
        console.log('AXIOS ERROR: ', err);
      });
  }

  handleClickOpen = () => {
    this.setState({ open: true });
  };

  handleClose = () => {
    this.setState({ open: false });
  };

  handleChangeProduct = name => event => {
    if (
      name === 'ProductStatusTypeId' &&
      event.target.value > 2 &&
      event.target.value < 1
    ) {
      product[name] = 1;
    } else {
      product[name] = event.target.value;
    }
    this.setState({ product: product });
  };

  handleSubmit = event => {
    event.preventDefault();
    this.props.onAddProduct(product);
  };

  render() {
    product = this.state.product;
    return (
      <div>
        <Button
          variant="outlined"
          color="primary"
          onClick={this.handleClickOpen}
        >
          Add New
        </Button>
        <Dialog
          open={this.state.open}
          onClose={this.handleClose}
          aria-labelledby="alert-dialog-title"
          aria-describedby="alert-dialog-description"
        >
          <DialogTitle id="alert-dialog-title">
            {'Adding new product'}
          </DialogTitle>
          <DialogContent />
          <div className="card">
            <div className="card-body">
              <TextField
                id="textfield-sku"
                label="Sku"
                style={{ margin: 8 }}
                onChange={this.handleChangeProduct('sku')}
                placeholder="Placeholder"
                fullWidth
                margin="normal"
                variant="outlined"
                InputLabelProps={{
                  shrink: true
                }}
              />
              <TextField
                id="textfield-name"
                label="Name"
                style={{ margin: 8 }}
                onChange={this.handleChangeProduct('name')}
                placeholder="Placeholder"
                fullWidth
                margin="normal"
                variant="outlined"
                InputLabelProps={{
                  shrink: true
                }}
              />
              <TextField
                id="textfield-thumbnail"
                label="Thumbnail"
                style={{ margin: 8 }}
                placeholder="Image link"
                onChange={this.handleChangeProduct('productImage')}
                fullWidth
                margin="normal"
                variant="outlined"
                InputLabelProps={{
                  shrink: true
                }}
              />
              <TextField
                id="textfield-image1"
                label="Image 1"
                style={{ margin: 8 }}
                placeholder="Placeholder"
                onChange={this.handleChangeProduct('image1')}
                fullWidth
                margin="normal"
                variant="outlined"
                InputLabelProps={{
                  shrink: true
                }}
              />
              <TextField
                id="textfiel-image2"
                label="Image 2"
                style={{ margin: 8 }}
                placeholder="Placeholder"
                onChange={this.handleChangeProduct('image2')}
                fullWidth
                margin="normal"
                variant="outlined"
                InputLabelProps={{
                  shrink: true
                }}
              />
              <TextField
                id="textfield-image3"
                label="Image 3"
                style={{ margin: 8 }}
                placeholder="Placeholder"
                onChange={this.handleChangeProduct('image3')}
                fullWidth
                margin="normal"
                variant="outlined"
                InputLabelProps={{
                  shrink: true
                }}
              />
              <TextField
                id="textfield-image4"
                label="Image 4"
                style={{ margin: 8 }}
                placeholder="Placeholder"
                onChange={this.handleChangeProduct('image4')}
                fullWidth
                margin="normal"
                variant="outlined"
                InputLabelProps={{
                  shrink: true
                }}
              />
              <TextField
                id="textfield-description"
                label="Description"
                style={{ margin: 8 }}
                onChange={this.handleChangeProduct('description')}
                placeholder="Full Description!"
                fullWidth
                margin="normal"
                variant="outlined"
                InputLabelProps={{
                  shrink: true
                }}
              />
              <TextField
                id="textfield-detail"
                label="Detail"
                style={{ margin: 8 }}
                onChange={this.handleChangeProduct('detail')}
                placeholder="Placeholder"
                multiline
                margin="normal"
                variant="outlined"
              />
              <TextField
                id="textfield-promotion-price"
                label="Promotion Price"
                type="number"
                style={{ margin: 8 }}
                onChange={this.handleChangeProduct('promotionPrice')}
                InputLabelProps={{
                  shrink: true
                }}
                margin="normal"
                variant="outlined"
              />
              <TextField
                id="textfield-regular-price"
                label="Regular Price"
                type="number"
                style={{ margin: 8 }}
                onChange={this.handleChangeProduct('regularPrice')}
                InputLabelProps={{
                  shrink: true
                }}
                margin="normal"
                variant="outlined"
              />
              <TextField
                id="textfield-quantity"
                label="Quantity"
                type="number"
                style={{ margin: 8 }}
                onChange={this.handleChangeProduct('quantity')}
                InputLabelProps={{
                  shrink: true
                }}
                margin="normal"
                variant="outlined"
              />

              <TextField
                id="textfield-weight"
                label="Weight"
                type="number"
                style={{ margin: 8 }}
                onChange={this.handleChangeProduct('weight')}
                InputLabelProps={{
                  shrink: true
                }}
                margin="normal"
                variant="outlined"
              />
              <TextField
                id="textfield-width"
                label="Width"
                type="number"
                style={{ margin: 8 }}
                onChange={this.handleChangeProduct('width')}
                InputLabelProps={{
                  shrink: true
                }}
                margin="normal"
                variant="outlined"
              />
              <TextField
                id="textfield-height"
                label="Height"
                type="number"
                style={{ margin: 8 }}
                onChange={this.handleChangeProduct('height')}
                InputLabelProps={{
                  shrink: true
                }}
                margin="normal"
                variant="outlined"
              />
              <TextField
                id="textfield-length"
                label="Length"
                type="number"
                style={{ margin: 8 }}
                onChange={this.handleChangeProduct('length')}
                InputLabelProps={{
                  shrink: true
                }}
                margin="normal"
                variant="outlined"
              />

              <TextField
                id="textfield-product-status"
                select
                label="Is stock?"
                style={{ margin: 8, width: 209 }}
                value={this.state.product.ProductStatusId}
                onChange={this.handleChangeProduct('ProductStatusTypeId')}
                margin="normal"
                variant="outlined"
              >
                <MenuItem key={1} value={1}>
                  {'Stock'}
                </MenuItem>
                <MenuItem key={2} value={2}>
                  {'Out of Stock'}
                </MenuItem>
              </TextField>

              <TextField
                id="textfield-category"
                select
                label="Category"
                style={{ margin: 8, width: 209 }}
                value={this.state.product.categoryId}
                onChange={this.handleChangeProduct('categoryId')}
                margin="normal"
                variant="outlined"
              >
                {this.state.categories.map((item, index) => (
                  <MenuItem key={index} value={item.id}>
                    {item.name}
                  </MenuItem>
                ))}
              </TextField>
            </div>
            <Button onClick={e => this.handleSubmit(e)} color="primary">
              Add
            </Button>
          </div>
        </Dialog>
      </div>
    );
  }
}

export default ProductDialog;
