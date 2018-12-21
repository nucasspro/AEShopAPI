import React, { Component } from 'react';
import Tabs from '@material-ui/core/Tabs';
import Tab from '@material-ui/core/Tab';
import AppBar from '@material-ui/core/AppBar';
import Typography from '@material-ui/core/Typography';
import ProductTable from './products/ProductTable';
import CategoryTable from './CategoryTable';

function TabContainer(props) {
  return (
    <Typography component="div" style={{ padding: 8 * 3 }}>
      {props.children}
    </Typography>
  );
}

export default class DashBoard extends Component {
  state = {
    value: 0
  };

  handleChange = (event, value) => {
    this.setState({ value });
  };

  render() {
    const { value } = this.state;
    return (
      <React.Fragment>
        <AppBar position="static">
          <Tabs fullWidth value={value} onChange={this.handleChange}>
            <Tab label="Products" />
            <Tab label="Categories" />
          </Tabs>
        </AppBar>
        {value === 0 && (
          <TabContainer>
            {/* <ProductTable /> */}
            <CategoryTable />

          </TabContainer>
        )}
        {value === 1 && (
          <TabContainer>
            {/* <CategoryTable /> */}
          </TabContainer>
        )}
      </React.Fragment>
    );
  }
}
