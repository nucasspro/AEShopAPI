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
    category: {
      name: null,
      description: null,
      image: null,
      categoryStatusType: {
        id: 1
      }
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
    category[name] = event.target.value;
    this.setState({ category: category });
  };

  handleSubmit = event => {
    event.preventDefault();
    this.props.onAddCategory(category);
  };

  render() {
    category = this.state.category;
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
                onChange={this.handleChange('image')}
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
