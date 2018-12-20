import React from 'react';
import axios from 'axios';
import { BASE_URL } from '../settings';
import {
  withStyles,
  DialogTitle,
  DialogContent,
  Dialog,
  Button,
  MenuItem,
  TextField
} from '@material-ui/core';

let category = {};

class CategoryDialog extends React.Component {
  state = {
    open: false,
    product: [],
    categories: {
        id: 0,
        name: "Undefined",
        description: "Undefined",
        image: "Undefined",
        parentId: null,
        productCategories: null,
        insertedAt: "12/05/2018",
        updatedAt: "12/05/2018"
    }
  };

  componentDidMount() {
    this.getCategories();
  }

  getCategories() {
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

    handleChange = name => event => {
    //   if (
    //     name === 'ProductStatusId' &&
    //     event.target.value > 2 &&
    //     event.target.value < 1
    //   ) {
    //     product[name] = 1;
    //   } else {
    //     product[name] = event.target.value;
    //   }
    //   this.setState({ product: product });
    };

  handleSubmit = event => {
    event.preventDefault();
    this.props.onAddProduct(category);
  };

  render() {
    category = this.state.product;
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
                placeholder="Image link"
                onChange={this.handleChange('productImage')}
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
                onChange={this.handleChange('image1')}
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
                onChange={this.handleChange('image2')}
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
                onChange={this.handleChange('image3')}
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
                onChange={this.handleChange('image4')}
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
                id="textfield-product-status"
                select
                label="Is stock?"
                style={{ margin: 8, width: 209 }}
                value={this.state.product.ProductStatusId}
                onChange={this.handleChange('ProductStatusId')}
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
                onChange={this.handleChange('categoryId')}
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

export default CategoryDialog;
