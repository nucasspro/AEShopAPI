import { FETCH_POSTS, NEW_POST } from '../actions/types';

const initialStage = {
    items: [],
    item: {}
};

export default function (state = initialStage, action) {
    switch (action.type) {
        case FETCH_POSTS:
            return {
                ...state,
                items: action.posts
            };
        case NEW_POST:
            return {
                ...state,
                item: action.post
            };
        default:
            return state;
    }
}
