import React, { Component } from 'react';
//import PropTypes from 'prop-types';
import { connect } from 'react-redux';
import axios from 'axios';
import { fetchPosts } from '../actions/postActions';

class Posts extends Component {
    state = {
        posts: []
    };

    componentWillMount() {
        axios.get('api/home/getall')
            .then(response => { this.setState({ posts: response.data }) })
            .catch(function (error) { console.log(error); });
        console.log(this.state.posts)
    }
    componentWillReceiveProps(nextProps, nextContext) {
        if (nextProps.newPost) {
            this.props.posts.unshift(nextProps.newPost);
        }
    }

    render() {
        return <div>{this.state.posts.map((item, index) => <div key={index}>
            <h3>{item.detail}</h3>
        </div>
        )}</div>;
    }
}

//Posts.propTypes = {
//    fetchPosts: PropTypes.func.isRequired,
//    posts: PropTypes.array.isRequired,
//};

const mapStateToProps = state => {
    return {
        posts: state.items
    }
    //newPost: state.posts.item
};

export default connect(
    mapStateToProps,
    { fetchPosts }
)(Posts);