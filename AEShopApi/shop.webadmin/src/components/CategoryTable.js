import React, { Component } from 'react';
import axios from 'axios';
// import CategoryDialog from './CategoryDialog';
import DeleteIcon from '@material-ui/icons/Delete';
import { BASE_URL } from '../settings';
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

class CategoryTable extends Component {
  constructor(props) {
    super(props);
    this.state = {
      categories: [],
      isLoading: true,
      error: null,
      button: { size: 'large' },
      searchText: '',
      editVisible: false,
      addNewVisible: false
    };
  }

  handleAdd = category => {
    let axiosConfig = {
      headers: {
        'Content-Type': 'application/json;charset=UTF-8',
        'Access-Control-Allow-Origin': '*'
      }
    };

    axios
      .post(`${BASE_URL}/categories`, category, axiosConfig)
      .then(res => {
        console.log('RESPONSE RECEIVED: ', res);
        this.getCategory();
      })
      .catch(err => {
        console.log('AXIOS ERROR: ', err);
      });
  };

  async getCategory() {
    try {
      var response = await axios.get(`${BASE_URL}/categories`);

      this.setState({
        categories: response.data,
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

  handleDelete(id) {
    let axiosConfig = {
      headers: {
        'Content-Type': 'application/json;charset=UTF-8',
        'Access-Control-Allow-Origin': '*'
      }
    };

    axios
      .delete(`${BASE_URL}/categories/${id}`, axiosConfig)
      .then(res => {
        console.log('RESPONSE RECEIVED: ', res);
        this.getCategory();
      })
      .catch(err => {
        console.log('AXIOS ERROR: ', err);
      });
  }

  componentDidMount() {
    this.getCategory();
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
            <h4 className="header-title">Category Table</h4>
            <div className="btn-add-new mb-3">
              {/* <CategoryDialog onAddProduct={this.handleAdd} /> */}
            </div>
            <div className="data-tables">
              <div
                id="dataTable3_wrapper"
                className="dataTables_wrapper dt-bootstrap4 no-footer"
              >
                <Table className="toolbar">
                  <TableHead>
                    <TableRow>
                      <CustomTableCell>Id</CustomTableCell>
                      <CustomTableCell>Name</CustomTableCell>
                      <CustomTableCell>Status</CustomTableCell>
                      <CustomTableCell>Created At</CustomTableCell>
                      <CustomTableCell>Updated At</CustomTableCell>
                      <CustomTableCell>Actions</CustomTableCell>
                    </TableRow>
                  </TableHead>
                  <TableBody>
                    {this.state.categories.map(row => {
                      return (
                        <TableRow key={row.id}>
                          <CustomTableCell component="th" scope="row">
                            {row.id}
                          </CustomTableCell>
                          <CustomTableCell>{row.name}</CustomTableCell>
                          <CustomTableCell>{row.status}</CustomTableCell>
                          <CustomTableCell>{row.createAt}</CustomTableCell>
                          <CustomTableCell>{row.updatedAt}</CustomTableCell>
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

export default withStyles(styles)(CategoryTable);
