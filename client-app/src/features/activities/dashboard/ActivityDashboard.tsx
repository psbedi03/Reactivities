import React, { useEffect } from "react";
import { Grid, GridColumn } from "semantic-ui-react";
import ActivityList from "./ActivityList";
import { useStore } from "../../../app/stores/store";
import { observer } from "mobx-react-lite";
import LoadingComponent from "../../../app/layout/LoadingComponent";


export default observer( function ActivityDashboard() {
  
  const {activityStore} = useStore();
  const {loadActivities, activityRegistry} = activityStore;

  useEffect(() => {
    if(activityRegistry.size <= 1) loadActivities();
  }, [loadActivities, activityRegistry.size]) //empty array means this only runs once


  if(activityStore.loadingInitial) return <LoadingComponent content='Loading app'/>
  return (
    <Grid>
      <Grid.Column width="10">
        <ActivityList/>
      </Grid.Column>
      <GridColumn width="6">
        <h2>Activity filters</h2>
        {/* {selectedActivity && !editMode &&
          <ActivityDetails/>
        }
        {editMode &&
        <ActivityForm/>} */}
      </GridColumn>
    </Grid>
  );
})
