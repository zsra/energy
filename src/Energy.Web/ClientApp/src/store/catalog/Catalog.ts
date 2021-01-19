import { Action, Reducer } from 'redux';
import { AppThunkAction } from '..';

export interface CatalogState {
    IsLoading: boolean;
    Catalog: CatalogItemViewModel[];
}

export interface CatalogItemViewModel {
    Id: string;
    Name: string;
    Brand: string;
    PictureUri: string;
    Category: string;
    Price: number;
}

interface RequestCatalogItemsAction {
    type: 'REQUEST_CATALOG_ITEMS';
}

interface ReceiveCatalogItemsAction {
    type: 'RECEIVE_CATALOG_ITEMS';
    items: CatalogItemViewModel[];
}

type KnownAction = RequestCatalogItemsAction | ReceiveCatalogItemsAction;

export const actionCreators = {
    requestCatalogItemsAction: (): AppThunkAction<KnownAction> => (dispatch, getState) => {
        const appState = getState();
        if (appState && appState.catalogItems) {
            fetch(`catalogitems`)
                .then(response => response.json() as Promise<CatalogItemViewModel[]>)
                .then(data => {
                    dispatch({ type: 'RECEIVE_CATALOG_ITEMS', items : data });
                });
            dispatch({ type: 'REQUEST_CATALOG_ITEMS' });
        }
    }
};

const unloadedState: CatalogState = { Catalog: [], IsLoading: false };

export const reducer: Reducer<CatalogState> = (state: CatalogState | undefined, incomingAction: Action): CatalogState => {
    if (state === undefined) {
        return unloadedState;
    }

    const action = incomingAction as KnownAction;
    switch (action.type) {
        case 'REQUEST_CATALOG_ITEMS':
            return {
                Catalog: state.Catalog,
                IsLoading: true
            };
        case 'RECEIVE_CATALOG_ITEMS':
            return {
                Catalog: action.items,
                IsLoading: false
            };
            break;
    }
    return state;
};
