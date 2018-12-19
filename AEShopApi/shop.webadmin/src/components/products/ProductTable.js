import React, { Component } from 'react';
import axios from 'axios';
import ProductDialog from './ProductDialog';
import DeleteIcon from '@material-ui/icons/Delete';
import { BASE_URL } from '../../settings';
import { withStyles } from '@material-ui/core/styles';
import {
  Fab,
  Table,
  TableBody,
  TableCell,
  TableHead,
  TableRow,
  Paper
} from '@material-ui/core';

const CustomTableCell = withStyles(theme => ({
  head: {
    backgroundColor: theme.palette.common.blue,
    color: theme.palette.common.white
  },
  body: {
    fontSize: 14
  }
}))(TableCell);

const styles = theme => ({
  root: {
    width: '100%',
    marginTop: theme.spacing.unit * 3,
    overflowX: 'auto'
  },
  table: {
    minWidth: 700
  },
  row: {
    '&:nth-of-type(odd)': {
      backgroundColor: theme.palette.background.default
    }
  }
});

class ProductTable extends Component {
  constructor(props) {
    super(props);
    this.state = {
      products: [],
      isLoading: true,
      error: null,
      button: { size: 'large' },
      searchText: '',
      editVisible: false,
      addNewVisible: false
    };
  }

  async getProducts() {
    try {
      var response = await axios.get(`${BASE_URL}/products`);

      this.setState({
        products: response.data,
        isLoading: false
      });
    } catch (error) {
      this.setState({
        error: error,
        isLoading: false
      });
      console.log(this.state.error.message);
    }
  }

  deleteProduct = id => {
    let axiosConfig = {
      headers: {
        'Content-Type': 'application/json;charset=UTF-8',
        'Access-Control-Allow-Origin': '*'
      }
    };

    axios
      .delete(`${BASE_URL}/products/${id}`, axiosConfig)
      .then(res => {
        console.log('RESPONSE RECEIVED: ', res);
        this.getProducts();
      })
      .catch(err => {
        console.log('AXIOS ERROR: ', err);
      });
  };

  handleDelete(id) {
    this.deleteProduct(id);
  }

  componentDidMount() {
    this.getProducts();
  }

  handleOpenModal = () => {
    this.setState({ addNewVisible: true });
  };

  handleCloseModal = () => {
    this.setState({ addNewVisible: false });
  };

  render() {
    return (
      <Paper>
        <div className="card">
          <div className="card-body">
            <h4 className="header-title">Product Table</h4>
            <div className="btn-add-new mb-3">
              <ProductDialog />
            </div>
            <div className="data-tables datatable-dark">
              <div
                id="dataTable3_wrapper"
                className="dataTables_wrapper dt-bootstrap4 no-footer"
              >
                <Table className="toolbar">
                  <TableHead>
                    <TableRow>
                      <CustomTableCell>Id</CustomTableCell>
                      <CustomTableCell>Name</CustomTableCell>
                      <CustomTableCell>Sku</CustomTableCell>
                      <CustomTableCell>Quantity</CustomTableCell>
                      <CustomTableCell>Regular Price</CustomTableCell>
                      <CustomTableCell>Actions</CustomTableCell>
                    </TableRow>
                  </TableHead>
                  <TableBody>
                    {this.state.products.map(row => {
                      return (
                        <TableRow key={row.id}>
                          <TableCell component="th" scope="row">
                            {row.id}
                          </TableCell>
                          <CustomTableCell>{row.name}</CustomTableCell>
                          <CustomTableCell>{row.sku}</CustomTableCell>
                          <CustomTableCell>{row.quantity}</CustomTableCell>
                          <CustomTableCell>{row.regularprice}</CustomTableCell>
                          <CustomTableCell>
                            <Fab
                              aria-label="Delete"
                              className="fab"
                              onClick={() => this.handleDelete(row.id)}
                            >
                              <DeleteIcon />
                            </Fab>
                          </CustomTableCell>
                        </TableRow>
                      );
                    })}
                  </TableBody>
                </Table>
              </div>
            </div>
          </div>
        </div>
      </Paper>
    );
  }
}

export default withStyles(styles)(ProductTable);
