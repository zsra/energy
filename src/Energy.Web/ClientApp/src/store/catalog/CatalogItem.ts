import { Action, Reducer } from 'redux';
import { AppThunkAction } from '..';

export interface CatalogItemState {
    item: CatalogItem;
}

export interface CatalogItem {
    Id: string;
    Name: string;
    Description: string;
    Brand: string;
    Price: number;
    PictureUris: string[];
    CreatedAt: Date;
    AvailableFrom: Date;
    Weight: Weight;
    Dimension: Dimension;
    Properties: [];
    Category: Category;
    Reviews: Review[];
}

export interface Weight {

}

export interface Dimension {

}

export interface Category {

}

export interface Review {

}

export interface CreateCatalogItemAction { type: 'CREATE' }
export interface UpdateCatalogItemAction { type: 'UPDATE' }
export type KnownAction = CreateCatalogItemAction | UpdateCatalogItemAction;

export const actionCreators = {
    create: () => ({ type: 'CREATE' } as CreateCatalogItemAction ),
    update: () => ({ type: 'UPDATE' } as UpdateCatalogItemAction )
};
