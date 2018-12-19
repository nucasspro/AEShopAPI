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
      ProductStatusId: 1,
      description: null,
      detail: null,
      weight: null,
      width: null,
      height: null,
      length: null,
      promotionPrice: 1,
      regularPrice: null,
      categoryId: null,
      productImage: null,
      image1: null,
      image2: null,
      image3: null,
      image4: null,
      discountId: null
    }
  };

  handleClickOpen = () => {
    this.setState({ open: true });
  };

  handleClose = () => {
    this.setState({ open: false });
  };

  handleChange = name => event => {
    if (
      name === 'ProductStatusId' &&
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
    let axiosConfig = {
      headers: {
        'Content-Type': 'application/json;charset=UTF-8',
        'Access-Control-Allow-Origin': '*'
      }
    };

    axios
      .post(`${BASE_URL}/products`, product, axiosConfig)
      .then(res => {
        console.log('RESPONSE RECEIVED: ', res);
      })
      .catch(err => {
        console.log('AXIOS ERROR: ', err);
      });
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
                onChange={this.handleChange('sku')}
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
                onChange={this.handleChange('name')}
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
                placeholder="Placeholder"
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
                onChange={this.handleChange('description')}
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
                onChange={this.handleChange('detail')}
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
                onChange={this.handleChange('promotionPrice')}
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
                onChange={this.handleChange('regularPrice')}
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
                onChange={this.handleChange('quantity')}
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
                onChange={this.handleChange('weight')}
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
                onChange={this.handleChange('width')}
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
                onChange={this.handleChange('height')}
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
                onChange={this.handleChange('length')}
                InputLabelProps={{
                  shrink: true
                }}
                margin="normal"
                variant="outlined"
              />

              <TextField
                id="outlined-select-currency"
                select
                label="Is stock?"
                style={{ margin: 8, width: 209 }}
                value={this.state.product.ProductStatusId}
                onChange={this.handleChange('ProductStatusId')}
                margin="normal"
                variant="outlined"
              >
                <MenuItem key={1} value={'1'}>
                  {'Stock'}
                </MenuItem>
                <MenuItem key={2} value={'2'}>
                  {'Out of Stock'}
                </MenuItem>
              </TextField>
            </div>
            <Button onClick={this.handleSubmit} color="primary">
              Add
            </Button>
          </div>
        </Dialog>
      </div>
    );
  }
}

export default ProductDialog;
