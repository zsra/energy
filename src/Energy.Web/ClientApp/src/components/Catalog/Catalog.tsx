import * as React from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../../store';
// import * as WeatherForecastsStore from '../store/WeatherForecasts';
import * as CatalogStore from '../../store/catalog/Catalog';

type CatalogProps = CatalogStore.CatalogState 
    & typeof CatalogStore.actionCreators
    & RouteComponentProps<{}>;
// // At runtime, Redux will merge together...
// type WeatherForecastProps =
//   WeatherForecastsStore.WeatherForecastsState // ... state we've requested from the Redux store
//   & typeof WeatherForecastsStore.actionCreators // ... plus action creators we've requested
//   & RouteComponentProps<{ startDateIndex: string }>; // ... plus incoming routing parameters

class Catalog extends React.PureComponent<CatalogProps> {

  public componentDidMount() {
    this.ensureDataFetched();
  }

  public componentDidUpdate() {
    this.ensureDataFetched();
  }

  public render() {
    return (
      <React.Fragment>
        {this.renderCatalogView()}
      </React.Fragment>
    );
  }

  private ensureDataFetched(){
    this.props.requestCatalogItemsAction();
  }

  private renderCatalogView(){
    return (
    <table className='table table-striped' aria-labelledby="tabelLabel">
      <thead>
        <tr>
          <th>Name</th>
        </tr>
      </thead>
      <tbody>
          {this.props.Catalog.map((items: CatalogStore.CatalogItemViewModel) =>
            <tr key={items.Id}>
              <td>{items.Name}</td>
            </tr>
          )}
      </tbody>
    </table>
    ); 
  }
}

export default connect(
  (state: ApplicationState) => state.catalogItems,
  CatalogStore.actionCreators
)(Catalog as any);


// class FetchData extends React.PureComponent<WeatherForecastProps> {
//   // This method is called when the component is first added to the document
//   public componentDidMount() {
//     this.ensureDataFetched();
//   }

//   // This method is called when the route parameters change
//   public componentDidUpdate() {
//     this.ensureDataFetched();
//   }

//   public render() {
//     return (
//       <React.Fragment>
//         <h1 id="tabelLabel">Weather forecast</h1>
//         <p>This component demonstrates fetching data from the server and working with URL parameters.</p>
//         {this.renderForecastsTable()}
//         {this.renderPagination()}
//       </React.Fragment>
//     );
//   }

//   private ensureDataFetched() {
//     const startDateIndex = parseInt(this.props.match.params.startDateIndex, 10) || 0;
//     this.props.requestWeatherForecasts(startDateIndex);
//   }

//   private renderForecastsTable() {
//     return (
//       <table className='table table-striped' aria-labelledby="tabelLabel">
//         <thead>
//           <tr>
//             <th>Date</th>
//             <th>Temp. (C)</th>
//             <th>Temp. (F)</th>
//             <th>Summary</th>
//           </tr>
//         </thead>
//         <tbody>
//           {this.props.forecasts.map((forecast: WeatherForecastsStore.WeatherForecast) =>
//             <tr key={forecast.date}>
//               <td>{forecast.date}</td>
//               <td>{forecast.temperatureC}</td>
//               <td>{forecast.temperatureF}</td>
//               <td>{forecast.summary}</td>
//             </tr>
//           )}
//         </tbody>
//       </table>
//     );
//   }

//   private renderPagination() {
//     const prevStartDateIndex = (this.props.startDateIndex || 0) - 5;
//     const nextStartDateIndex = (this.props.startDateIndex || 0) + 5;

//     return (
//       <div className="d-flex justify-content-between">
//         <Link className='btn btn-outline-secondary btn-sm' to={`/fetch-data/${prevStartDateIndex}`}>Previous</Link>
//         {this.props.isLoading && <span>Loading...</span>}
//         <Link className='btn btn-outline-secondary btn-sm' to={`/fetch-data/${nextStartDateIndex}`}>Next</Link>
//       </div>
//     );
//   }
// }

// export default connect(
//   (state: ApplicationState) => state.weatherForecasts, // Selects which state properties are merged into the component's props
//   WeatherForecastsStore.actionCreators // Selects which action creators are merged into the component's props
// )(FetchData as any); // eslint-disable-line @typescript-eslint/no-explicit-any
